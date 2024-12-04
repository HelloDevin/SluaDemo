GameObject = UnityEngine.GameObject

local M = {}
function M:Start()
    print("Start")
    -- self.transform:Find("btn") 会产生一个临时变量，方法执行完下次Lua.GC会自动回收
    --self.btnTran = self.transform:Find("btn")
    self.btn = self.transform:Find("btn"):GetComponent("Button")
    -- self.btnOnClick 缓存临时变量起来，方法执行完下次Lua.GC不会自动回收，只有当self.btnOnClick=nil后才会被回收
    self.btnOnClick = self.btn.onClick
    self.btn.onClick:AddListener(function()
        print("click")
    end)
end

function M:Update()
    if UnityUtil.GetInputKeyDown(UnityEngine.KeyCode.Q) then
        print("Q")
        --self.transform = nil
        self.btn.onClick:RemoveAllListeners()
    end
end

function M:OnDestroy()
    print("OnDestroy")
    --self.gameObject = nil
    --self.transform = nil
    --self.btn.onClick:RemoveAllListeners()
    --self.btn = nil

    for k, v in pairs(self) do
        print(k, v, type(v))

        if type(v) == 'userdata' then
            --Button
            local mt = getmetatable(v)
            if rawget(mt, "onClick") then
                v["onClick"]:RemoveAllListeners()
            end
            self[k] = nil
        end
    end
end

return M


