local Delgate = Class("Delgate")

function Delgate:ctor() 
    self._callList={}
end


function Delgate:Subscribe( object,method )
    local _key = {obj=object,func=method}
    local _call = Util.Handler(object,method)
    rawset(self._callList,_key,_call)
end
function Delgate:UnSubscribe( object,method )
    local _key 
    for k,v in pairs(self._callList) do
        if (k.obj==object and k.func==method) then
            _key=k
            break
        end
    end
    if( _key ~=nil) then
        self._callList[_key]=nil
    end
end

function Delgate:Invoke( ... )
    for k,v in pairs(self._callList) do
        v(...)
    end
end

function Delgate:Dispose()
    TableUtil.ClearTable(self._callList)
end

return Delgate