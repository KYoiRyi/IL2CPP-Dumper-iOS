ARCHS = arm64
TARGET := iphone:clang:16.5:12.0

INSTALL_TARGET_PROCESSES ?=

include $(THEOS)/makefiles/common.mk

TWEAK_NAME = IL2CPPDumper

IL2CPPDumper_FILES = \
	Dump/src/main.cxx \
	Dump/src/platform.cxx \
	Dump/src/utils.cxx \
	Dump/src/il2cpp_api.cxx \
	Dump/src/il2cpp_image.cxx \
	Dump/src/il2cpp_class.cxx \
	Dump/src/dumper.cxx \
	Dump/src/scene_dumper.cxx

IL2CPPDumper_CFLAGS = -fobjc-arc -I$(CURDIR)/Dump/include
IL2CPPDumper_CCFLAGS = -std=c++17 -fno-rtti -I$(CURDIR)/Dump/include

include $(THEOS_MAKE_PATH)/tweak.mk
